namespace PDFReader.Utilities;


internal class FRTicketFactory : TicketFactoryBase
{
    protected override DateOnly CreateDate(int[] dateAsArray)
    {
        return new DateOnly(dateAsArray[2], dateAsArray[1], dateAsArray[0]);
    }
}