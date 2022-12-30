```

 int a=Convert.ToInt32(Console.ReadLine());

   int Display(int a)
 {
    if(a==0)
    {
        return 0;
    }
    if(a==1)
    {
        return 1;
    }
    else{
        return Display(a-1)+Display(a-2);
    }
 }
 int s=Display(a);
 Console.WriteLine(s);

 
 ```

 