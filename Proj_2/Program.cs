
string resp;

Console.WriteLine("This is A Walk in the Dark, an interactive story, choose from the given choices and progress, or else.");
Console.WriteLine("Lets try it!");
Console.WriteLine("Do you understand?");
Console.WriteLine("(y)Yea/(n)No");
resp = Console.ReadLine().ToLower();

if(resp == "y"){
    Console.WriteLine("Great!.");

    Console.WriteLine("Do you go into the a)forest b)farm");
    resp = Console.ReadLine().ToLower();

    if(resp == "a"){
        Console.WriteLine("You choose to go into the forest.");
        Console.WriteLine("You find tracks leading into the forest.");
        Console.WriteLine("Do you a)follow the tracks b)continue walking through the forest c)go home");
        resp = Console.ReadLine().ToLower();

        if(resp == "a"){
            Console.WriteLine("You follow the tracks.");
            Console.WriteLine("After dome time of walking you see a body on the forest floor.");
            Console.WriteLine("It looks mutulated but youre not sure.");
            Console.WriteLine("Do you a)investigate b)go home");
            resp = Console.ReadLine().ToLower();

            if(resp == "a"){
                Console.WriteLine("You walk towards the body, looking down on it you se how its face is completelly destroyed.");
                Console.WriteLine("There are large bite marks all over the body but also stabb wounds.");
                Console.WriteLine("As you're getting up you feel something jumping on your back and your neck being cut up and broken.");
            }
        }
        else if(resp == "b"){
            Console.WriteLine("You continue walking, you find a large wood structure in a large swamp.");
            Console.WriteLine("Do you a)investigate b)turn back");
            resp = Console.ReadLine().ToLower();

            if(resp == "a"){
                Console.WriteLine("You walk towrds the camp, you hear voices in a language you cant understand.");
                Console.WriteLine("You get a glimpse inside the camp and see bodies hung up, and small green creatures.");
                Console.WriteLine("You turn around to walk back when you feel something sharp pierce your skull.");
            }
            else if(resp == "b"){
                Console.WriteLine("You turn back and make a steaming hot cup of coco.");
            }
            else{
                Console.WriteLine("Choose a viable answer next time.");
            }
        }
        else if(resp == "c"){
            Console.WriteLine("You walk home and have a lovely cup of tea.");
        }
        else{
             Console.WriteLine("Choose a viable answer next time.");
        }
    }
    else if(resp == "b"){
        Console.WriteLine("You walk toward the farm, you see a farmer out on the field.");
        Console.WriteLine("Do you a)approach the farmer b)walk back home");
        resp = Console.ReadLine().ToLower();

        if(resp == "a"){
            Console.WriteLine("You aapproach the farmer and have a pleasant conversation and he invites you into his house.");
            Console.WriteLine("Do you a) decline his offer and turn back b)follow him inside");
            resp = Console.ReadLine().ToLower();

            if(resp == "a"){
                Console.WriteLine("You follow the farmer into the house.");
                Console.WriteLine("He offers you a cup of tea.");
                Console.WriteLine("Do you a)decline b)accept");
                resp = Console.ReadLine().ToLower();

                if(resp == "a"){
                    Console.WriteLine("The farmer seams hurt but does not insist further.");
                    Console.WriteLine("He says that you are welcome to stay for a while, as he continues working on the field.");
                    Console.WriteLine("Do you a)search the house b)have some tea c)leave");
                    resp = Console.ReadLine().ToLower();
                

                    if(resp == "a"){
                        Console.WriteLine("You walk around the house, you find mostly what you'd expect in a farmers house.");
                        Console.WriteLine("You find a trap door in the floor.");
                        Console.WriteLine("You jump down into a basement.");
                        Console.WriteLine("You find bodies upon bodies, all mutulated and dead.");
                        Console.WriteLine("Suddenly you feel something warm trickling down your stomach.");
                        Console.WriteLine("You realise you've been stabbed, and that you are about to join the others.");
                    }
                    else if(resp == "b"){
                        Console.WriteLine("You have some tea and sit in a comfy chair by the fire");
                        Console.WriteLine("You suddenly feel like something is squeezing your lungs, preventing you from breathing.");
                        Console.WriteLine("You start feeling dizzy and collapse on the floor.");
                    }
                    else if(resp == "c"){
                        Console.WriteLine("You leave the house and walk home, making yourself a nice cup of coffee you reflect over your lovely day.");
                    }
                    else{
                        Console.WriteLine("Choose a viable option next time.");
                    }
                }
                else if(resp == "b"){
                    Console.WriteLine("He pours you a cup and places it infront of you.");
                    Console.WriteLine("You take a sip and enjoy the nice hot feeling in your body.");
                    Console.WriteLine("You look up and see the farmer smiling a disconserting smile.");
                    Console.WriteLine("You suddenly feel like something is squeezing your lungs, preventing you from breathing.");
                    Console.WriteLine("You start feeling dizzy and collapse on the floor.");
                }
                else{
                    Console.WriteLine("Choose a viable answer next time.");
                }
            }
            else if(resp == "b"){
                Console.WriteLine("As you turn around to leave you feel a cold hand on your shoulder and as you look backyou hole world is consumed by this horrible face.");
                Console.WriteLine("I insist, the farmer says.");
                Console.WriteLine("You get dragged in to the house and killed.");
            }
            else{
                Console.WriteLine("Choose a viable answer next time.");
            }
        }
        else if(resp == "b"){
            Console.WriteLine("You walk back home, having enjoyed your walk and have a nice cool bottle of lemonade.");
        }
        else{
            Console.WriteLine("Choose a viable answer next time.");
        }
    }
    else{

        Console.WriteLine("Choose a viable answer next time.");
    }
}
else if(resp == "n"){
    Console.WriteLine("Alright then F off.");
}
else{
    Console.WriteLine("Choose a viable answer next time.");
}


Console.ReadLine();