//Members

public class Person {
    // Felt
    private string name;

    // Egenskab
    public string Name {
        get { return name; }
        set { name = value; }
    }

    // Metode
    public void SayHello() {
        Console.WriteLine("Hello, " + Name);
    }
}

//Accesibility (tilgængelighed)

public class Person2 {
    private string name; // Kun tilgængelig inden for klassen
    public void SayHello() { /* ... */ } // Tilgængelig overalt hvor klassen er tilgængelig
}

//Properties 

public class Person3 {
    private int age;
    public int Age {
        get { return age; }
        set {
            if(value >= 0) age = value;
        }
    }
}

//Constructors

public class Person4 {
    public string Name { get; set; }
    public Person4(string name) {
        Name = name;
    }
}

// Arv 

public class Employee : Person {
    public int Id { get; set; }
}

//  Static vs Dynamic Method Dispatch

public class Person5 {
    public virtual void SaySomething() {
        Console.WriteLine("I am a person.");
    }
}

public class Student : Person5 {
    public override void SaySomething() {
        Console.WriteLine("I am a student.");
    }
}


