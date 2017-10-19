            string cardAscii = @"
            
                {0}           
                ______________
               |              |
               |Attack:   {1}   |
               |              |
               |              |
               |Defense:   {2}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~   
                {3}                 
                                ";

           string emptyCard = @"
                ______________
               |              |
               |              |
               |              |
               |              |
               |              |
               |              |
               |              |
                ~~~~~~~~~~~~~~   ";

           string deadCard = @"
                ______________
               |\            /|
               |  \        /  |
               |    \    /    |
               |      \/      |
               |    /   \     |
               |  /       \   |
               |/           \ |
                ~~~~~~~~~~~~~~   ";

            
            string fieldAscii = @"
            
                {0}            {4}             {8}        
                ______________          ______________          ______________
               |              |        |              |        |              |
               |Attack:   {1}   |        |Attack:   {5}   |        |Attack:   {9}   |
               |              |        |              |        |              |
               |              |        |              |        |              |
               |Defense:   {2}  |        |Defense:   {6}  |        |Defense:   {10}  |
               |              |        |              |        |              |
               |              |        |              |        |              |
                ~~~~~~~~~~~~~~          ~~~~~~~~~~~~~~          ~~~~~~~~~~~~~~   
                {3}             {7}            {11}                 
                                ";
        Console.WriteLine(fieldAscii, "Sleepy Allen", 1, 9,"DEFENSE MODE","Awoke Allen", 9, 1, "ATTACK MODE", "Regular Allen", 5, 5, "ATTACK MODE");