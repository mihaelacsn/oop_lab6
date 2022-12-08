using System;
using System.IO;

class Beverage{
        Random random = new Random();
        String beverage_name, type_drink, type_extra, type_dessert;
        String[] beverage;
        int total_per_customer;
        
        String[] types_of_tea;
        
        String[] types_of_coffee = new String[9];
        
        String[] types_of_cold_drinks = new String[6];
        
        String[] types_of_syrup = new String[4];
        
        String[] types_of_milk = new String[4];
        
        String[] types_of_desserts = new String[4];
        
        int[] tea_prices = new int[5]{20,20,25,20,25};
        int[] coffee_prices = new int[9]{26,25,23,20,25,25,27,32,24};
        int[] cold_drink_prices = new int[6]{25,25,25,20,20,35};
        int syrup_prices = 4;
        int[] milk_prices = new int[4]{8,8,8,4};
        int ice_price = 2;
        int[] dessert_prices = new int[4]{35,45,47,40};

    public Beverage(){
        beverage = new String[3];
        types_of_tea = new String[5];
        total_per_customer = 0;
        beverage[0] = "tea";
        beverage[1] = "coffee";
        beverage[2] = "cold drink";
        types_of_tea[0] = "black";
        types_of_tea[1] = "green";
        types_of_tea[2] = "fruity";
        types_of_tea[3] = "herbal";
        types_of_tea[4] = "ginger";
        types_of_coffee[0] = "latte";
        types_of_coffee[1] = "cappuccino";
        types_of_coffee[2] = "americano";
        types_of_coffee[3] = "espresso";
        types_of_coffee[4] = "doppio";
        types_of_coffee[5] = "mocha";
        types_of_coffee[6] = "flat white";
        types_of_coffee[7] = "irish";
        types_of_coffee[8] = "machiato";
        types_of_cold_drinks[0] = "cola";
        types_of_cold_drinks[1] = "fanta";
        types_of_cold_drinks[2] = "sprite";
        types_of_cold_drinks[3] = "water";
        types_of_cold_drinks[4] = "sparkling water";
        types_of_cold_drinks[5] = "classic lemonade";
        types_of_syrup[0] = "caramel";
        types_of_syrup[1] = "vanilla";
        types_of_syrup[2] = "hazelnut";
        types_of_syrup[3] = "creme brulee";
        types_of_milk[0] = "coconut";
        types_of_milk[1] = "almond";
        types_of_milk[2] = "soya";
        types_of_milk[3] = "cow";
        types_of_desserts[0] = "brownie";
        types_of_desserts[1] = "classic cheesecake";
        types_of_desserts[2] = "cherry cheesecake";
        types_of_desserts[3] = "oreo cake";

        type_extra = "none";
        type_dessert = "none";

        setBeverageType();
        setDrinkType();
    }

    public void setBeverageType(){
        beverage_name = beverage[random.Next()%3];
    }
    public void setDrinkType(){
        if(String.Equals("tea",beverage_name)){
                int teatype = random.Next()%5;
                type_drink = types_of_tea[teatype];
                total_per_customer+=tea_prices[teatype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 2){//syrup
                    int extratype = random.Next()%4;
                    type_extra = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else if(String.Equals("coffee",beverage_name)){
                int coffeetype = random.Next()%9;
                type_drink = types_of_coffee[coffeetype]; 
                total_per_customer+=coffee_prices[coffeetype];
                int extra_choice = random.Next()%9;
                int dessert_choice = random.Next()%3;
                 if(extra_choice == 2){//syrup
                 int extratype = random.Next()%4;
                    type_extra = types_of_syrup[extratype];
                    total_per_customer+=syrup_prices;
                }else if(extra_choice == 4){//ice
                    type_extra = "ice";
                    total_per_customer+=ice_price;
                } else if(extra_choice == 7){//milk
                    int extratype = random.Next()%4;
                    type_extra = types_of_milk[extratype];
                    total_per_customer+=milk_prices[extratype];
                    
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }else{
                int colddrinktype = random.Next()%6;
                type_drink = types_of_cold_drinks[colddrinktype];
                total_per_customer+=cold_drink_prices[colddrinktype];
                int extra_choice = random.Next()%4;
                int dessert_choice = random.Next()%3;
                if(extra_choice == 1 || extra_choice == 2 || extra_choice == 3){
                    type_extra= "ice";
                    total_per_customer+=ice_price;
                }
                if(dessert_choice == 1 || dessert_choice == 2){
                    int desserttype = random.Next()%4;
                    type_dessert = types_of_desserts[desserttype];
                    total_per_customer+=dessert_prices[desserttype];
                }
            }
    }

    public int getTotalAmountPaid(){
        return total_per_customer;
    }
};

class Customers{
    Random random = new Random();
    int number_of_people_per_day,number_of_people_per_week,number_of_people_per_month;
    int total_per_day, total_per_month,total_per_week;
    Beverage[] beverages;
    public Customers(){
        int i;
        number_of_people_per_day = random.Next()%30;
        beverages = new Beverage[number_of_people_per_day];
        for (i = 0; i < number_of_people_per_day; i++){
            beverages[i] = new Beverage();
        
        }
    }

    public int getTotalAmountPerDay(){
        int i;
        total_per_day = 0;
         number_of_people_per_day = random.Next()%30;
         beverages = new Beverage[number_of_people_per_day];
            for (i = 0; i < number_of_people_per_day; i++){
                beverages[i] = new Beverage();
                total_per_day+=beverages[i].getTotalAmountPaid();
            }
        return total_per_day;
    }

    public int getTotalAmountPerWeek(){
        int i;
        total_per_week = 0;
        number_of_people_per_week = 0;
        for(i = 0; i < 7; i++){
           total_per_week+= getTotalAmountPerDay();
           number_of_people_per_week+=number_of_people_per_day;
        }
        return total_per_week;
    }

    public int getTotalAmountPerMonth(){
        int i;
        total_per_month = 0;
        for(i = 0; i < 4; i++){
            total_per_month += getTotalAmountPerWeek();
            number_of_people_per_month+=number_of_people_per_week;
        }
        return total_per_month;
    }

    public int getNumberOfPeoplePerDay(){
        return number_of_people_per_day;
    }

    public int getNumberOfPeoplePerWeek(){
        return number_of_people_per_week;
    }

    public int getNumberOfPeoplePerMonth(){
        return number_of_people_per_month;
    }
}

//main
class my_coffee_shop
{
    static public void Main()
    {
        
        Customers customers = new Customers();

        Console.WriteLine(customers.getTotalAmountPerDay()+" lei made today from "+customers.getNumberOfPeoplePerDay()+" customers.");
        Console.WriteLine("Want to check how much you will do next month? ");
        String choice = Console.ReadLine();
        while(String.Equals("y",choice)){
        Console.WriteLine("    "+customers.getTotalAmountPerDay()+" lei made today from "+customers.getNumberOfPeoplePerDay()+" customers.");
        Console.WriteLine("  "+customers.getTotalAmountPerWeek()+" lei made this week from "+customers.getNumberOfPeoplePerWeek()+" customers.");
        Console.WriteLine(customers.getTotalAmountPerMonth()+" lei made this month from "+customers.getNumberOfPeoplePerMonth()+" customers.");
        Console.WriteLine("Want to check how much you will do next month? ");
        choice = Console.ReadLine();
        }

        
        
    }
}
