using System; 

class URI {

    static void Main(string[] args) { 

        int init_days = int.Parse(Console.ReadLine().Substring(4));
        string[] entry = Console.ReadLine().Split(" : ");
        int init_hours = int.Parse(entry[0]);
        int init_minutes = int.Parse(entry[1]);
        int init_seconds = int.Parse(entry[2]);
        
        int end_days = int.Parse(Console.ReadLine().Substring(4));
        entry = Console.ReadLine().Split(" : ");
        int end_hours = int.Parse(entry[0]);
        int end_minutes = int.Parse(entry[1]);
        int end_seconds = int.Parse(entry[2]);
        
       int new_days, new_hours, new_minutes, new_seconds = 0;
       if (end_seconds >= init_seconds) {
         new_seconds = end_seconds - init_seconds;
       } else {
         new_seconds = 60 + end_seconds - init_seconds;
         end_minutes -= 1;
       }
       if (end_minutes >= init_minutes) {
         new_minutes = end_minutes - init_minutes;
       } else {
         new_minutes = 60 + end_minutes - init_minutes;
         end_hours -= 1;
       }
       if (end_hours >= init_hours) {
         new_hours = end_hours - init_hours;
       } else {
         new_hours = 24 + end_hours - init_hours;
         end_days -= 1;
       }
      new_days = end_days - init_days;

      Console.WriteLine(new_days + " dia(s)"); 
      Console.WriteLine(new_hours + " hora(s)"); 
      Console.WriteLine(new_minutes + " minuto(s)"); 
      Console.WriteLine(new_seconds + " segundo(s)"); 
    }

}
