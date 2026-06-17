using N17_T2;

AuthService auth = new AuthService();

Console.WriteLine(auth.IsValidEmail("jasurabdulxaev@gmail.com"));       // True
Console.WriteLine(auth.IsValidEmail("alijonsattorqulov2@gmail.com"));   // True
Console.WriteLine(auth.IsValidEmail("@gmail.com"));                     // False
Console.WriteLine(auth.IsValidEmail("oydinoykamolova1gmail.com"));      // False