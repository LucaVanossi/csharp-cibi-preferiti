// See https://aka.ms/new-console-template for more information

string[] CibiPreferiti = { "Pizza", "Pasta", "Riso", "Salumi", "Torta" };

Console.WriteLine("Il numero dei cibi inseriti è :" + CibiPreferiti.Length);

for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.WriteLine(i +1 + ". " + CibiPreferiti[i]);
    
}

Console.WriteLine("Il mio cibo preferito è : " + CibiPreferiti[0]);
Console.WriteLine("Tra i miei preferiti l'ultimo è : " + CibiPreferiti[4]);

int calcolo = CibiPreferiti.Length / 2;

if (CibiPreferiti.Length %2 ==0)
{
    Console.WriteLine("Il cibo a metà classifica è: " + CibiPreferiti[calcolo]);
} 
else
{
    Console.WriteLine("I cibi a metà classifica sono: " + CibiPreferiti[calcolo -1] + " e " +
        CibiPreferiti[calcolo]);
}
