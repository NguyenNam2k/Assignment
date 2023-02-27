import java.util.Scanner;
public class Worker extends Person {
    private double workHours;
    private final double RATE = 5.5;

    public Worker(){}
    public Worker(String n, double hrs) {
        super(n);
        this.workHours= hrs;
    }
    public double getSalary() {
        return workHours*RATE;
    }
    public double getAnnualSalary() {
        return getSalary()*12;
    }
    public void input() {
        super.input();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter work hours: ");
        workHours = scanner.nextDouble();
    }
    public void display() {
        super.display();
        System.out.println("Work hours: " + workHours);
        System.out.println("Salary rate: "+ RATE);
        System.out.println("Salary: "+ getSalary());
        System.out.println("Annual Salary: " + getAnnualSalary());
    }
}