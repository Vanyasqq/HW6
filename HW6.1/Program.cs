

string[] num = Console.ReadLine().Split(new char[] { ',' });
int count =0;
for(int i=0;i<num.Length;i++)
{
int inum = System.Convert.ToInt32(num[i]);
    
    if(inum > 0)
    {
        count ++;
    }
}
Console.WriteLine(count);

