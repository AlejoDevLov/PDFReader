namespace PDFReader.Utilities;

/// <summary>
/// Helper that extracts the index of the separator character (':') and the title text
/// from a collection of ticket data lines.
/// </summary>
/// <remarks>
/// The <see cref="Extract"/> method expects that the string at the provided index
/// contains a separator character ':' followed by a space and then the title text
/// (e.g. "title: The Movie Name"). The returned title is the substring that starts
/// two characters after the separator (skipping the ':' and the following space).
/// </remarks>
internal class TicketFactoryTitleAndSeparatorIndexExtractor
{
    /// <summary>
    /// Extracts the zero-based index of the first ':' in the targeted ticket line and
    /// returns that index together with the title text that follows the separator.
    /// </summary>
    /// <param name="ticketsData">A sequence of ticket data lines.</param>
    /// <param name="i">The zero-based index into <paramref name="ticketsData"/> identifying the line to parse.</param>
    /// <returns>
    /// A tuple where the first item is the zero-based position of ':' in the selected line,
    /// and the second item is the title substring that starts two characters after the ':'.
    /// </returns>
    /// If the selected line does not contain ':' or <c>i</c> is out of range, the method
    /// may throw exceptions (for example, <see cref="System.ArgumentOutOfRangeException"/>).
    /// Callers should ensure the input is well-formed or validate before calling.
    /// </remarks>
    public static (string, int) Extract(IEnumerable<string> ticketsData, int i)
    {
        // Takes the first element in the current iteration(title: nameOfMovie...) and returns the position of semicolon (:) in the string
        var indexOfSeparator = ticketsData
            .ElementAt(i)
            .IndexOf(':');

        // Gets rid of the string at the leftside of the semicolon, leaving only the name of the movie
        var title = ticketsData
            .ElementAt(i)
            [(indexOfSeparator + 2)..];

        return new(title, indexOfSeparator);
    }
}