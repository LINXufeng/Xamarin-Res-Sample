using Xamarin.Forms;

namespace TodoREST
{
	public static class Constants
	{
        // The iOS simulator can connect to localhost. However, Android emulators must use the 10.0.2.2 special alias to your host loopback interface.
        //public static string BaseAddress = Device.RuntimePlatform == Device.Android ? "http://ec2-34-201-136-58.compute-1.amazonaws.com:8080" : "http://ec2-34-201-136-58.compute-1.amazonaws.com:8080";
        public static string BaseAddress = "http://ec2-184-73-114-254.compute-1.amazonaws.com:8080";
        public static string TodoItemsUrl = BaseAddress + "/canteen";
    }
}
