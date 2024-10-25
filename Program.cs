//Array Sınıfı Methodları

//Sort(Sıralama)
int[] sayidizisi = {23,12,4,86,72,3,11,17};

Console.Write("Sırasız Dizi: ");
foreach (var sayi in sayidizisi)
    Console.Write(sayi + " ");
    Console.WriteLine(" ");

Array.Sort(sayidizisi);
Console.Write("Sıralı Dizi: ");
foreach (var sayi in sayidizisi)
    Console.Write(sayi + " ");
    Console.WriteLine(" ");

//Clear

Console.Write("Array Clear: ");
Array.Clear(sayidizisi,2,3); //sayidizisi elemanlarını kullanarak 2. indexten başlayarak 3 tane elemanı sıfırlar.
foreach (var sayi in sayidizisi)
    Console.Write(sayi + " ");
    Console.WriteLine(" ");

//Reverse

Array.Reverse(sayidizisi);
Console.Write("Array Reverse: ");
foreach (var sayi in sayidizisi)
    Console.Write(sayi + " ");
    Console.WriteLine(" ");

//IndexOff

Console.Write("Array IndexOff: ");
Console.Write(Array.IndexOf(sayidizisi,23)); //Sayı dizisi içinde 23 değeri kaçıncı indekste olduğunu verir.
Console.WriteLine(" ");

//Resize (Yeniden Boyutlandırma)

Console.Write("Array Resize: ");
Array.Resize<int>(ref sayidizisi, 9);
sayidizisi[8]=99;
foreach (var sayi in sayidizisi)
    Console.Write(sayi + " ");