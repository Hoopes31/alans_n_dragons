            string cardAscii = @"
            
                '{0}'           
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
                {0}'s Field

                '{1}'        
                ______________
               |              |
               |Attack:   {2}   |  
               |              |
               |              |         
               |Defense:   {3}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~
                {4}

                '{5}'        
                ______________
               |              |
               |Attack:   {6}   |  
               |              |
               |              |         
               |Defense:   {7}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~
                {8}

                '{9}'        
                ______________
               |              |
               |Attack:   {10}   |  
               |              |
               |              |         
               |Defense:   {11}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~
                {12}               
                                    
                                                
                                ";
        Console.WriteLine(fieldAscii, "Sleepy Allen", 1, 9,"DEFENSE MODE","Awoke Allen", 9, 1, "ATTACK MODE", "Regular Allen", 5, 5, "ATTACK MODE");