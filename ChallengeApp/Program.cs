/// Napisz w Program.cs kod w którym:
/// - zadeklarujesz zmienną z imieniem
/// - zadeklarujesz zmienną z płcią (dobierz zmienną)
/// - zadeklarujesz zmienną z wiekiem
/// - zweryfikujesz dane i wyświetlisz
/// jeden z komunikatów:
/// (1): "Kobieta poniżej 30 lat"
/// (2): "Ewa, lat 33"
/// (3): "Niepełnoletni Mężczyzna"
/// ---------------------------
/// (możesz dodać swoje)

string name = "Ewa";
string sex = "Female";
int age = 17;

if (name == "Ewa" && sex == "Female" && age == 17)



if (sex == "Female" && age > 30)

{
    Console.WriteLine("Ewa, lat 33");
}

else if (sex == "Female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
