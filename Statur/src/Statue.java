class Statue extends Item {
    private String creator;
    private int weight;
    private String colour;

    public Statue(String value, String creator, int d, String colour) {
        super(value);
        this.creator = creator;
        this.weight = d;
        this.colour = colour;
    }

    public String getCreator() {
        return creator;
    }

    public double getWeight() {
        return weight;
    }

    public String getColour() {
        return colour;
    }

    public String toString() {
        return getValue() + " by " + creator + ", " + weight + "kg, " + colour;
    }
}
