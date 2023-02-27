import java.util.Scanner;

public class Employee extends Person {
    private double baseSalary;

    public Employee() {}
    public Employee(String n, double s) {
        super(n);
        this.baseSalary = s;
    }
    public double getSalary(){
        return baseSalary;
    }
    public double getAnnualSalary() {
        return baseSalary*12;
    }
    public void input() {
        super.input();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter base salary: ");
        baseSalary = scanner.nextDouble();
    }
    public void display() {
        super.display();
        System.out.println("Base salary: "+ baseSalary);
        System.out.println("Annual salary: "+ getAnnualSalary());
    }
}