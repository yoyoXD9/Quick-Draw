using static System.Net.WebRequestMethods;

namespace Quick_Draw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Menu = @"
Quick Draw
Face your opponent and wait for the signal. Once the
signal is given, shoot your opponent by pressing [space]
before they shoot you. It&#39;s all about your reaction time.
Choose Your Opponent:
[1] Easy....1000 milliseconds
[2] Medium...500 milliseconds
[3] Hard.....250 milliseconds
[4] Harder...125 milliseconds&quot;;const string Menu = @&quot;
Quick Draw
Face your opponent and wait for the signal. Once the
signal is given, shoot your opponent by pressing [space]
before they shoot you. It&#39;s all about your reaction time.
Choose Your Opponent:
[1] Easy....1000 milliseconds
[2] Medium...500 milliseconds
[3] Hard.....250 milliseconds
[4] Harder...125 milliseconds";

            const string Wait = @"
    _O               O_
   /|L              L|\
   / \     wait     / \";

            const string Fire = @"
********
* FIRE *
_O ******** O_
|/|_ _|\|
/\ spacebar /\
/ | | \
------------------------------------------------------";

            Console.WriteLine(Fire);
        }
    }
}
