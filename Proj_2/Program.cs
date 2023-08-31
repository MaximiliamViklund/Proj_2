
string resp;

Console.WriteLine("This is *Proj2* an interactive story, chosse from the given choices and progress.");
Console.WriteLine("Lets try it!");
Console.WriteLine("Do you understand?");
Console.WriteLine("(y)Yea/(n)No");
resp = Console.ReadLine();
if(resp == "n"){
    Console.WriteLine("Alright then F off.");
}
else if(resp == "y"){
    Console.WriteLine("Great!.");

    Console.WriteLine("xxx");
    Console.WriteLine("Do you a)xxx b)yyy c)zzz");
    resp = Console.ReadLine();

    if(resp == "b"){

    }
    else if(resp == "c"){

    }
    else if(resp == "a"){

    }
    else{
        Console.WriteLine("Chosse a viable answer next time.");
    }
}


Console.ReadLine();