using PR;







    Console.WriteLine(" ----------------------------------------------------------------------------");
    Console.WriteLine("|                          School Management                                 |");
    Console.WriteLine(" ----------------------------------------------------------------------------");
    Console.WriteLine("*                           Emeliyyati Secin                                 *");
    Console.WriteLine("*                                                                            *");
    Console.WriteLine("*                           1 Muellimler ucun                                *");
    Console.WriteLine("*                                                                            *");
    Console.WriteLine("*                           2 Sagirdler ucun                                 *");
    int secim =Convert.ToInt32(Console.ReadLine());
    Operation.OpTeacher(secim);
    Operation.OpStudent(secim);
     








