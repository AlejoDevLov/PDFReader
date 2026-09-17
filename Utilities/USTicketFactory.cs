namespace PDFReader.Utilities;

using PDFReader.DTOs;
using System.Globalization;

internal class USTicketFactory
{
    public static IEnumerable<Ticket> CreateTicket(IEnumerable<string> ticketsData)
    {
        var tickets = new List<Ticket>();

        // This loop is increase by 3 in each iteration to be sure of taking the three values 
        // each ticket has (title, date and time) in case there is more than one ticket in the string.
        for (int i = 0; i < ticketsData.Count(); i += 3)
        {
            // Takes the first element in the current iteration(title: nameOfMovie...) and returns the position of semicolon (:) in the string
            // Gets rid of the string at the leftside of the semicolon, leaving only the title of the movie
            var (title, indexOfSeparator) = TicketFactoryTitleAndSeparatorIndexExtractor.Extract(ticketsData, i);

            // Passes the second element in the current iteration(date: dateOfMovie) and the separator for dates
            var dateAsArray = TicketFactoryDateAndTimeExtractor.Extract(ticketsData, i + 1, indexOfSeparator + 1, ['/'], 0);

            // Passes the third element in the current iteration (time: timeOfMovie), its respective separators for time
            // and skips the last element (PM/AM).
            var timeAsArray = TicketFactoryDateAndTimeExtractor.Extract(ticketsData, i + 2, indexOfSeparator + 1, [':', ' '], 1);

            // Takes the third element in the current iteration (time: timeOfMovie...) and validates if it contains PM or AM in its format.
            // To convert it in 24h format.
            if (ticketsData.ElementAt(i + 2).Contains("PM"))
            {
                timeAsArray[0] = timeAsArray[0] < 12
                                     ? timeAsArray[0] += 12
                                     : timeAsArray[0];
            }
            else if (ticketsData.ElementAt(i + 2).Contains("AM"))
            {
                timeAsArray[0] = timeAsArray[0] == 12
                                     ? timeAsArray[0] = 00
                                     : timeAsArray[0];
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var time = new TimeSpan(timeAsArray[0], timeAsArray[1], 00);
            var date = new DateOnly(dateAsArray[2], dateAsArray[0], dateAsArray[1]);

            tickets.Add(new Ticket(title, date, time));
        }

        return tickets;
    }
}
