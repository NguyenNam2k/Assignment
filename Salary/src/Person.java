import java.util.Scanner;

public abstract class Person {
    private String name;

    public Person() {}

    public Person(String n) {
        this.name = n;
    }

    public String getName() {
        return name;
    }

    public void setName(String n) {
        this.name = n;
    }

    public abstract double getSalary();

    public void input() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter name: ");
        name = scanner.nextLine();
    }
    
    public void display() {
        System.out.println("Name: "+ name);
        System.out.println("Salary: "+ getSalary());
    }
}