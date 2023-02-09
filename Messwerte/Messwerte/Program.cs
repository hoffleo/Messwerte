int anzahl;
int WertC = 11;
Console.Clear();
Console.WriteLine("Wie viele Messwerte liegen vor?");
anzahl = Convert.ToInt32(Console.ReadLine());
int[] inpL = new int[anzahl];
Console.WriteLine("Geben Sie die Messwerte für L ein.");
for (int i = 0; i < anzahl; i++)
{
    inpL[i] = Convert.ToInt32(Console.ReadLine());
}
double res;
int counter = 0;
foreach (int l in inpL)
{
    counter = counter + 1;
    res = 1 / (2 * Math.PI * Math.Sqrt(l * WertC));
    Console.WriteLine("Die " + counter + ". Messung ergab eine Resonanzfrequenz von: " + res);
}