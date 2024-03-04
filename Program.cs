namespace abstraction
{
    internal class Program
    {
          static void Main(string[] args)
          {
            cargoplane cp = new cargoplane();
            passengerplane pp = new passengerplane();
            fighterplane fp = new fighterplane();



            airport.permit(cp);
            airport.permit(fp);
            airport.permit(pp);

          }
    }
}
