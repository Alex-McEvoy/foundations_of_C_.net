// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}



class MyInventory
{
    public static void Main()
    {
        int item_count = 0;
        // use an interger to keep track of the count of items in your inventory					
        ItemData[] item_array = new ItemData[100];
        bool exit_program = false;
        // create an array of your ItemData struct
        // use a never ending loop that shows the user what options they can select 
        // as long as no one Quits, continue the inventory update
        // in that loop, show what user can select from the list
        // read the user's input and then create what case it falls

        while (true)
        {
            if (exit_program == true)   //test to see if exit program and 'y' have already been selected
                break;
            Console.WriteLine("Welcome to your inventory control. Please select an option..");
            Console.WriteLine("1.) Add an item\n2.) Change an item\n3.) Delete an item\n4.) List your items\n5.) Quit.");

            string optx = Console.ReadLine();  // read user's input	
            
            // if(char.IsNumber(strx[0]) && !char.IsWhiteSpace(strx[0]))
            //{

                //int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below.

                Console.WriteLine(); // provide an extra blank line on screen

                switch (optx)
                {
                    case "1": // add an item to the list if this option is selected
                        {
                            if (item_count > 100)
                            {
                                Console.WriteLine("Item limit exceeded. Please delete an item to continue adding");
                                break;
                            }
                            else
                            {
                                item_array[item_count].itemIDNo = item_count + 1; //add an automatic item ID

                                Console.Write("Please enter the item description: "); //get the item description
                                item_array[item_count].sDescription = Console.ReadLine();

                                Console.Write("Please enter the price per item: $");  //get price per item
                                item_array[item_count].dblPricePerItem = double.Parse(Console.ReadLine());

                                Console.Write("Please enter how many you currently have on hand: "); //get current quantity
                                item_array[item_count].iQuantityOnHand = int.Parse(Console.ReadLine());

                                Console.Write("Please enter how much it costs us to manufacture: $"); //get our cost
                                item_array[item_count].dblOurCostPerItem = double.Parse(Console.ReadLine());
                                //calculate value of item (price * quantity on hand)
                                item_array[item_count].dblValueOfItem = item_array[item_count].dblPricePerItem * item_array[item_count].iQuantityOnHand;

                            }
                            item_count++;
                            break;
                        }

                    case "2": //change items in the list if this option is selected
                        {
                            Console.Write("Please enter an item ID No: ");
                            string strchgid = Console.ReadLine();
                            int chgid = int.Parse(strchgid);
                            bool fFound = false;

                            for (int x = 0; x < item_count; x++)
                            {
                                if (item_array[x].itemIDNo == chgid)
                                {
                                    bool break_loop = false;
                                    while (true)
                                    {
                                        if (break_loop == true)
                                            break;
                                        fFound = true;
                                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");  //display item to be modified
                                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                                        Console.WriteLine("{0,-7}{1,-8}{2,-22}${3,-7}{4,-4}${5,-5}${6,-5}", x + 1, item_array[x].itemIDNo,
                                            item_array[x].sDescription, item_array[x].dblPricePerItem,
                                            item_array[x].iQuantityOnHand, item_array[x].dblOurCostPerItem,
                                            item_array[x].dblValueOfItem);
                                        Console.WriteLine();



                                        Console.WriteLine("Please select an item to modify, note that current values will be cleared.");
                                        Console.WriteLine("1.) Description\n2.)Price Per Item\n3.)Quantity on Hand\n4.)Our Cost per Item\n5.) Quit");

                                        int choice = int.Parse(Console.ReadLine());

                                        switch (choice)
                                        {
                                            case 1:
                                                {
                                                    Console.Write("Enter new item description: ");
                                                    item_array[chgid - 1].sDescription = Console.ReadLine();
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.Write("Enter new price per item: ");
                                                    item_array[chgid - 1].dblPricePerItem = double.Parse(Console.ReadLine());
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    Console.Write("Enter new quantity on hand: ");
                                                    item_array[chgid - 1].iQuantityOnHand = int.Parse(Console.ReadLine());
                                                    item_array[chgid - 1].dblValueOfItem = item_array[chgid - 1].iQuantityOnHand + item_array[chgid - 1].dblOurCostPerItem;
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    Console.Write("Enter new cost per item: ");
                                                    item_array[chgid - 1].dblOurCostPerItem = double.Parse(Console.ReadLine());
                                                    item_array[chgid - 1].dblValueOfItem = item_array[chgid - 1].iQuantityOnHand + item_array[chgid - 1].dblOurCostPerItem;
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    break_loop = true;
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Please enter a valid value.");
                                                    break;
                                                }
                                        }
                                    }


                                    // code to show what has to happen if the item in the list is found
                                    // reset the count to show a new count for your list 
                                    // (Note: your list is now increased by one item)
                                }
                            }

                            if (!fFound) // and if not found
                            {
                                Console.WriteLine("Item {0} not found", chgid);
                            }

                            break;
                        }

                    case "3": //delete items in the list if this option is selected
                        {

                            Console.Write("Please enter an item ID No:");
                            string strnewid = Console.ReadLine();
                            int deleteMe = int.Parse(strnewid);
                            bool fDeleted = false;

                            for (int x = 0; x < item_count; x++)
                            {
                                if (item_array[x].itemIDNo == deleteMe)
                                {
                                    fDeleted = true;

                                    for (int i = deleteMe - 1; i < item_count; i++)     //use for loop to insert the next array item into deleteME's space. 
                                    {                                                   //continue through for all items
                                        item_array[i] = item_array[i + 1];
                                    }
                                    item_count--;
                                    // delete the item if you found it
                                    // reset the count to show a new count for your list 
                                    //(Note: your list is now reduced by one item)								
                                }
                            }

                            if (fDeleted) // hint the user that you deleted the requested item
                            {
                                Console.WriteLine("Item deleted");
                            }
                            else // if did not find it, hint the user that you did not find it in your list
                            {
                                Console.WriteLine("Item {0} not found", deleteMe);
                            }

                            break;
                        }

                    case "4":  //list all items in current database if this option is selected
                        {
                            Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                            Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                            for (int i = 0; i < item_count; i++)
                            {
                                Console.WriteLine("{0,-7}{1,-8}{2,-22}${3,-7}{4,-4}${5,-5}${6,-5}", i + 1, item_array[i].itemIDNo,
                                    item_array[i].sDescription, item_array[i].dblPricePerItem,
                                    item_array[i].iQuantityOnHand, item_array[i].dblOurCostPerItem,
                                    item_array[i].dblValueOfItem);
                                Console.WriteLine();
                            }
                            // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                            break;
                        }


                    case "5": //quit the program if this option is selected
                        {
                            Console.Write("Are you sure that you want to quit(y/n)?");
                            string strresp = Console.ReadLine();
                            strresp = strresp.ToLower();

                            if (strresp[0] == 'y')
                            {

                                exit_program = true;
                                break;

                            }
                            else if (strresp[0] == 'n')
                            {
                                optx = "0";   //as long as it is not 5, the process is not breaking	
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Option, try again");
                                break;
                            }
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option, try again");
                            break;
                        }
                }
          //    }
          //else
          //  {
          //      Console.WriteLine("Please select a valid option");
          //  }      

            }
            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }

