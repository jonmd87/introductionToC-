// text work
// 1. Intext need to change all spaces to underscore
// 2. All small letters "k" change to big "K"
// 4. All big "C" chenge to small letters "c"

string text = "Two households, both alike in dignity\n"
            + "In fair Verona, where we lay our scene,\n"
            + "From ancient grudge break to new mutiny,\n"
            + "Where civil blood makes civil hands unclean.\n"
            + "From forth the fatal loins of these two foes\n"
            + "A pair of star-crossed lovers take their life;\n"
            + "Whose misadventured piteous overthrows\n"
            + "Doth with their death bury their parents strife.\n"
            + "The fearful passage of their death-marked love\n"
            + "And the continuance of their parents rage,\n"
            + "Which, but their children was end, naught could remove,\n"
            + "Is now the two hourses traffic of our stage;\n"
            + "The which, if you with patient ears attend,\n"
            + "What here shall miss, our toil shall strive to mend.\n";

char space = ' ';
char underscore = '_';
char smallK = 'k';
char bigK = 'K';
char smallC = 'c';
char bigC = 'C';

string Replace(string text, char oldValue, char newValue)
{
    int length = text.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";

    }
    return result;
}

string newText = Replace(text, smallK, bigK);
newText = Replace(newText, smallC, bigC);
newText = Replace(newText, space, underscore);
System.Console.WriteLine(newText);