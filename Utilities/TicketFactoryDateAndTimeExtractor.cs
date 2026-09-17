namespace PDFReader.Utilities;


// This class is used to extract the values of interest like date and time from a collection of strings
// containing the data related to a ticket.
internal class TicketFactoryDateAndTimeExtractor
{
    // It takes the @indexOfElement in the current iteration (date: dateOfMovie / time: timeOfMovie) in the collection @ticketsData and
    // gets rid of the string at the leftside of the semicolon, leaving only the date/time and spliting it using the @separators symbols.
    // @indexOfSeparator represents the index of the separator ":" in (date: dateOfMovie / time: timeOfMovie)
    // @separators can be either "/", ":", " ". Thee're used to separate date or time
    // The @elementsToSkipAtLast is used for time to skip the value PM/AM when it has the 12h format
    // @return each value of the date/time as int[]
    public static int[] Extract(
        IEnumerable<string> ticketsData, 
        int indexOfElement, 
        int indexOfSeparator,
        char[] separators,
        int elementsToSkipAtLast
        )
    {
        return [.. ticketsData
            .ElementAt(indexOfElement)
            [indexOfSeparator..]
            .Split(separators)
            .SkipLast(elementsToSkipAtLast)
            .Select(el => int.Parse(el))];
    }
}

