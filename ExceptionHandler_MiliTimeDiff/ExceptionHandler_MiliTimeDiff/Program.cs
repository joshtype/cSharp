// Seconds calculator between 24hr times with exceptions handled
// @author      Joshua Gregory
// @version     1.0 (June 2024)
using ExceptionHandler_MiliTimeDiff;

namespace ExceptionHandler_MiliTimeDiff
{
    internal class Program
    {
        /**
         * Splits arg to str[], converts each cell to int, calculates number of seconds from midnight to arg.
         * Handles all exceptions (input str len, format, characters, etc).
         * @param:  str representation of a 24hr time (HH:MM:SS)
         * @return: number of seconds from midnight to param
         */
        public static int numMilitarySeconds(string inpTime)
        {
            // HANDLE EXCEPTIONS IN INITIAL INPUTS
            if (inpTime == null || inpTime.Length < 8)
            {
                // check inp len = 8, covers most errs (custom exception arg = 'm')
                throw new TimeInputErr("Input did not contain enough characters (8) for HH:MM:SS format.");
            }
            else if (!inpTime.Contains(':'))
            {
                // check input contains ':', covers invalid formats/chars (eg 12.24.36)
                throw new TimeInputErr("Input did not contain colons, eg: 12:24:36.");
            }

            // AFTER VALIDATING INPUT LEN && FORMAT
            string[] times = new string[3];  // split input to str[] at ':'
            times = inpTime.Split(':');      // 0th = hh, 1st = mm, 2nd = ss

            // HANDLE CONVERSION EXCEPTIONS 
            if (!Int32.TryParse(times[0], out int hh))  // covers invalid chars (eg 01:30:pm)
            {
                throw new TimeInputErr("Input for hours (HH) must be a positive, two-digit integer. Eg: 00, 11, 23.");
            }
            else
            {
                hh = int.Parse(times[0]);  // convert valid hh chars to int
            }
            if (!Int32.TryParse(times[1], out int mm))
            {
                throw new TimeInputErr("Input for minutes (MM) must be a positive, two-digit integer. Eg: 00, 33, 59.");
            }
            else
            {
                mm = int.Parse(times[1]);  // convert valid chars to int
            }
            if (!Int32.TryParse(times[2], out int ss))
            {
                throw new TimeInputErr("Input for seconds (SS) must be a positive, two-digit integer. Eg: 00, 33, 59.");
            }
            else
            {
                ss = int.Parse(times[2]);  // convert valid chars to int
            }

            // HANDLE OUT OF RANGE EXCEPTIONS
            if (hh < 0 || hh > 23)       // hh = [0,23]
            {
                throw new TimeInputErr("Input for hours (HH) must be 0 to 23.");
            }
            else if (mm < 0 || mm > 59)  // mm = [0,59]
            {
                throw new TimeInputErr("Input for minutes (MM) must be 0 to 59.");
            }
            else if (ss < 0 || ss > 59)  // ss = [0,59]
            {
                throw new TimeInputErr("Input for seconds (SS) must be 0 to 59.");
            }

            // calculate & return num seconds since midnitght; (HH*60*60)+(MM*60)+SS
            return (hh * 60 * 60) + (mm * 60) + ss;
        }

        // DRIVER
        static void Main(string[] args)
        {
            // get time 1, calc seconds since midnight
            Console.WriteLine("Enter the first time in 24hr military format (HH:MM:SS), including colons:");
            int n1 = numMilitarySeconds(Console.ReadLine());

            // get time 2, calc seconds since midnight
            Console.WriteLine("Enter the second time in 24hr military format (HH:MM:SS), including colons:");
            int n2 = numMilitarySeconds(Console.ReadLine());

            // display difference
            Console.WriteLine("The number of seconds between the first and second time = " + (n2 - n1));
        }
    }
}
