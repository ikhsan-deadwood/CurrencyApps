# Currency Apps
Aplikasi ini memungkinkan user untuk menghitung program dengan sistem USD ke Rupiah

# Scope & Fungtionalities
 - user dapat menginputkan
 - user dapat mengakses tombol hitung
 - user mendapat info "INVALID" jika yang dimasukkan berupa teks bukan angka


# How Does it works?
Dimulai dari method `MainWindow` pada class MainWindow.xaml.cs, kita mendeklarasikan :

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

1. Apa yang terjadi pada percobaan 1-3?
- Percobaan 1 = memberikan output dari frontend namun tidak memiliki logika
- Percobaan 2 = Jika yang dimasukkan adalah huruf maka akan terjadi crash
- Percobaan 3 = Jika yang dimasukkan adalah huruf maka akan muncul output berupa "Invalid"

2. Mengapa perlu membuat class CurrencyController.cs pada percobaan 4 ?
- Karena currencyController.cs merupakan logika dari program agar dapat berjalan sesuai prosedur yaitu bisa menghitung nilai tukar dan tujuan lainnya adalah untuk memisahkan antara yang mana bagian frontend, yang mana fungsi dan yang mana logika.

3. Jelaskan kegunaan method isAllowed pada percobaan 4!
- Fungsi dari method isAllowed yaitu supaya nilai dari nominalString bisa menggunakan boolean

4. Jelaskan secara singkat mengenai Regex pada percobaan 4!
- Regex adalah Konstruksi bahasa untuk mencocokkan teks berdasarkan pola tertentu

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
