using System;

public class Bela {
    public static void Main (string[] args) {
      // Variables are made
        string line = Console.ReadLine ();
        int gap = line.IndexOf (' ');
        int hand = int.Parse (line.Substring (0, gap)) * 4;
        char suit = line[gap + 1];
        int pointtotal = 0;
        for (int x = 0; x < hand; x++) {
            string s = Console.ReadLine ();
        // Cases are made for elseif statements
            switch (s[0]) {
                case 'A':
                    pointtotal += 11;
                    break;
                case 'K':
                    pointtotal += 4;
                    break;
                case 'Q':
                    pointtotal += 3;
                    break;
                case 'J':
                    if (s[1] == suit)
                        pointtotal += 20;
                    else
                        pointtotal += 2;
                    break;
                case 'T':
                    pointtotal += 10;
                    break;
                case '9':
                    if (s[1] == suit)
                        pointtotal += 14;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine (pointtotal);
    }
} // End of line
