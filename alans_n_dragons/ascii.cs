using System;
using System.Collections.Generic;

namespace alans_n_dragons 
{
    public class Ascii
    {
        public string cardAscii = @"
            
                '{0}'
                Number: {6}           
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

           public string emptyCard = @"
                ______________
               |              |
               |              |
               |              |
               |              |
               |              |
               |              |
               |              |
                ~~~~~~~~~~~~~~   ";

           public string deadCard = @"
                '{0}'
                   is DEAD
                ______________
               |\            /|
               |  \        /  |
               |    \    /    |
               |      \/      |
               |    /   \     |
               |  /       \   |
               |/           \ |
                ~~~~~~~~~~~~~~   ";

            
            public string fieldAscii = @"
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
            public string handAscii = @"
                {0}'s Hand

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

                 '{13}'        
                ______________
               |              |
               |Attack:   {14}   |  
               |              |
               |              |         
               |Defense:   {15}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~
                {16}   

                 '{17}'        
                ______________
               |              |
               |Attack:   {18}   |  
               |              |
               |              |         
               |Defense:   {19}  |
               |              |
               |              |
                ~~~~~~~~~~~~~~
                {20}                                  
                
                
                       ";
        public Ascii()
        {
        }
    }
}