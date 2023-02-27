import java.util.Scanner;
class Item {
    private String value;

    public Item(String value) {
        this.value = value;
    }

    public String getValue() {
        return value;
    }
}
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Statue[] statues = new Statue[10];

        Statue statue1 = new Statue("Statue 1", "Creator 1", 5, "Gold");
        Statue statue2 = new Statue("Statue 2", "Creator 2", 3, "Silver");
        statues[0] = statue1;
        statues[1] = statue2;
        
        System.out.print("Enter the number of additional statues: ");
        int m = scanner.nextInt();
        scanner.nextLine();

        for (int i = 0; i < m; i++) {
            System.out.println("Enter Statue " + (i+1) + ":");
            System.out.print("Value: ");
            String value = scanner.nextLine();
            System.out.print("Creator: ");
            String creator = scanner.nextLine();
            System.out.print("Weight: ");
            int weight = scanner.nextInt();
            scanner.nextLine(); // Consume newline character
            System.out.print("Colour: ");
            String colour = scanner.nextLine();

            statues[i+2] = new Statue(value, creator, weight, colour);
        }

        System.out.println("\nAll statues entered:");
        for (Statue statue : statues) {
            if (statue != null) {
                System.out.println(statue);
            }
        }

        System.out.print("\nEnter creator to search for: ");
        String searchCreator = scanner.nextLine();

        System.out.println("Statues by " + searchCreator + ":");
        for (Statue statue : statues) {
            if (statue != null && statue.getCreator().equals(searchCreator)) {
                System.out.println(statue);
            }
        }
    }
}
