package java0;
public class Main {
	public static void main(String args[])  
	{  
	int r=8, i, j, s = 1;    
	s = r - 1;  
	for (j = 1; j<= r; j++)  
	{  
	for (i = 1; i<= s; i++)  
	{  
	System.out.print(" ");  
	}  
	s--;  
	for (i = 1; i <= 2 * j - 1; i++)  
	{  
	System.out.print("*");  
	}  
	System.out.println("");  
	}  
	s = 1;  
	for (j = 1; j<= r - 1; j++)  
	{  
	for (i = 1; i<= s; i++)  
	{  
	System.out.print(" ");  
	}  
	s++;  
	for (i = 1; i<= 2 * (r - j) - 1; i++)  
	{  
	System.out.print("*");  
	}  
	System.out.println("");  
	}  
	}  

}
