import java.util.ArrayList;
import java.util.Scanner;

public class Fumanagement{
    private ArrayList<Person> personList;
    public Fumanagement() {
        personList = new ArrayList<Person>();
        personList.add(new Employee("Messi", 15));
        personList.add(new Worker("Aka Meo", 10));
        personList.add(new Worker("Biden", 200));
        personList.add(new Employee("Trong", 50));
    }
    public int getChoice() {
        Scanner scanner = new Scanner(System.in);
        System.out.println("1. Add Employee");
        System.out.println("2. Add Worker");
        System.out.println("3. Display All");
        System.out.println("4. Display Employees");
        System.out.println("5. Display Workers");
        System.out.println("6. Search by Name");
        System.out.println("0. Exit");
        System.out.print("Enter your choice (0-6): ");
        int choice = scanner.nextInt();
        return choice;
    }
    public void addEmployee() {
        Employee employee = new Employee();
        employee.input();
        personList.add(employee);
        System.out.println("Employee added successfully!");
    }
    public void addWorker() {
        Worker worker = new Worker();
        worker.input();
        personList.add(worker);
    }

    public Person getPerson(int indexSearch) {
        return personList.get(indexSearch);
    }

    public void displayAll() {
        for (Person person : personList) {
            person.display();
        }
    }

    public void displayEmployees() {
        for (Person person : personList) {
            if (person instanceof Employee) {
                person.display();
            }
        }
    }
    public void displayWorkers() {
        System.out.println("Displaying all workers:");
        for (Person person : personList) {
            if (person instanceof Worker) {
                person.display();
            }
        }
    }
    public void searchName() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter name to search: ");
        String name = scanner.nextLine();
        boolean found = false;
        for (Person person : personList) {
            if (person.getName().equals(name)) {
                person.display();
                found = true;
            }
        }
        if (!found) {
            System.out.println("Person not found.");
        }
    }
    public static void main(String[] args) {
        Fumanagement management = new Fumanagement();

        boolean quit = false;
        while (!quit) {
            int choice = management.getChoice();
            switch (choice) {
                case 1:
                    management.addEmployee();
                    break;
                case 2:
                    management.addWorker();
                    break;
                case 3:
                    management.displayAll();
                    break;
                case 4:
                    management.displayEmployees();
                    break;
                case 5:
                    management.displayWorkers();
                    break;
                case 6:
                    management.searchName();
                    break;
                case 7:
                    System.out.println("Goodbye!");
                    quit = true;
                    break;
                default:
                    System.out.println("Invalid choice.");
                    break;
            }
        }
    }
}
