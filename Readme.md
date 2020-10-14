# Currency App
apikasi ini mencakup fungsi perhitungan nilai tukar mata uang dari dolar ke rupiah.
satu dolar danggap senilai Rp. 15.000

# Scope & Fungtionalities
- user dapat memasukkan angka
- user dapat menyentuh tombol hitung
- usermendapat info "INVALID" jika yang dimasukkan berupa teks

# How Does it works?
Diawali dari method `MainWindow` pada class MainWindow.xaml.cs, kita mendeklarasikan :

```csharp
public MainWindow()
        {
            InitializeComponent();
            currencyController = new CurrencyController();
        }
```

Logika perhitungan terdapat pada class `CurrencyControll.cs` sebagai berikut :

```csharp
public string usdToIdr(string nominal)
        {
            var nominalDouble = Convert.ToDouble(nominal);
            var result = nominalDouble * 15000;
            return Convert.ToString(result);
        }
``` 


# Latihan

1. apa yang terjadi pada percobaan 1-3?
- percobaan 1 yaitu memunculkan frontend dari currency apps yang dibuat tapi belum memiliki fungsi logika
- percobaan 2 yaitu jika memasukkan sembarang angka maka angka tersebut akan dikali kan dengan 15000 dan jika yang dimasukkan adalah huruf maka akan terjadi crash
- percobaan 3 yaitu jika memasukkan sembarang angka maka angka tersebut akan dikali kan dengan 15000 dan jika yang dimasukkan adalah huruf maka akan muncul tulisan "Invalid"

2. Mengapa perlu membuat class CurrencyController.cs pada percobaan 4 ?
- karena currencyController.cs merupakan logika dari programnya agar bisa berjalan semestinya yaitu bisa menghitung nilai tukar dan tujuan lainnya adalah untuk memisahkan antara yang mana bagian frontend, yang mana fungsi dan yang mana logika.

3. Jelaskan kegunaan method isAllowed pada percobaan 4!
- yaitu agar nilai dari nominalString bisa menggunakan boolean

4. Jelaskan secara singkat mengenai Regex pada percobaan 4!
- adalah konstruksi bahasa untuk mencocokkan teks berdasarkan pola tertentu

5. Buatlah class diagramnya pada percobaan 4! 
```csharp
public partial class MainWindow : Window
    - public MainWindow()
    - private void Button_Hitung_Click
```

```csharp
class CurrencyController
  - public string usdToIdr(string nominal)
```