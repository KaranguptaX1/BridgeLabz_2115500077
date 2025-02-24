using System;
class HotelBooking{
    private string guestName;
    private string roomType;
    private int nights;
    // Default Constructor
    public HotelBooking(){
        guestName = "Unknown";
        roomType = "Standard";
        nights = 1;
    }
    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights){
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }
    // Copy Constructor
    public HotelBooking(HotelBooking booking){
        guestName = booking.guestName;
        roomType = booking.roomType;
        nights = booking.nights;
    }
    public void DisplayBooking(){
        Console.WriteLine($"Guest: {guestName}, Room: {roomType}, Nights: {nights}");
    }
}

class Program{
    static void Main(){
        HotelBooking booking1 = new HotelBooking("John Doe", "Deluxe", 3);
        HotelBooking booking2 = new HotelBooking(booking1);
		//Display output
        booking1.DisplayBooking();
        booking2.DisplayBooking();
    }
}
