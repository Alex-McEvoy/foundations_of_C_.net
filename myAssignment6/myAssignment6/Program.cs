using System;

namespace ConsoleApplication1
{
    public struct Pet //establishes a structure of type Pet as a global object, accessible to any class
    {
        public string Name; //makes Name public
        public string TypeOfPet; //public allows access to name and typeofpet from anywhere in the program
    }

    class Program
    {
        static void Main() //declare Main in Program
        {
            var numberOfPets = 0; //declares and assigns numberOfPets to 0
            var pets = new Pet[10]; //declares an array of structures of type Pet

            while(true) //set an endless loop to allow for multiple entries
            {
                Console.Write("A)dd D)elete L)ist pets:"); //Provide the user with a menu of options
                var choice = Console.ReadLine(); //get user input

                switch(choice) //use the input in a switch statement
                {
                    case "A": // When no action is given the switch statement proceeds to the next option.
                    case "a": //having "A" fall into "a" allows the user to enter either capital or lower case A
                        {
                            Console.Write("Name: "); 
                            var name = Console.ReadLine(); //get the new pets name

                            Console.Write("Type of Pet: ");
                            var typeOfPet = Console.ReadLine(); //get the new type of pet

                            //using numberOfPets as the array index sets to latest addition to the end of the array
                            pets[numberOfPets].Name = name; //set new pet name in array to the users input
                            pets[numberOfPets].TypeOfPet = typeOfPet; //set new type of pet in array to the users input

                            numberOfPets++; //update the number of pets so the next input doesnt overwrite this pet
                            break; //necessary to break out of the switch statement

                        }
                    case "D": //set case for if user wants to delete an entry
                    case "d": //user can enter upper or lowercase d
                        {
                            if(numberOfPets == 0) //check to see if we have any pets to delete
                            {
                                Console.WriteLine("No Pets"); //if not, we can't delete anything. let the user know
                                break; //freedom from the switch statement
                            }

                            for (var index = 0; index < numberOfPets; index++) //use a for loop to display all the pets we have
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //display the info for each pet. {1,-10} provides formatting to the output
                            }

                            Console.Write("Which pet to remove (1-{0}", numberOfPets);  //ask which pet to remove

                            var petNumberToDelete = Console.ReadLine(); //get user input
                            var indexToDelete = int.Parse(petNumberToDelete); //convert to integer

                            //copy over the array location we want to delete with the next pet in line. Continue throughout the array with a for loop

                            for (var index = indexToDelete - 1; index < numberOfPets; index++) //use the indexToDelete -1 to get to the correct location in the array
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            //we have one less pet now
                            numberOfPets--;

                            break; //escape from the switch statement

                        }

                    case "L":   //accept either upper or lowercase L
                    case "l":
                        {
                            if (numberOfPets == 0) //check to see if we have no pets
                            {
                                Console.WriteLine("No pets"); //let the user know
                            }

                            for (int index = 0; index < numberOfPets; index++) //use a for loop to list the pets we have in the database
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //display current pets in our array
                            }

                            break; //break out of the switch statement
                        }
                    default: //use the default statement if the user enters something other than a valid command
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); //Let the user know they entered a bad command
                            break; //and break from the statement
                        }


                }


            }
        }
    }

}
