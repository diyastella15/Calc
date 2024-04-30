#include <stdio.h>
int main() {
 
    int number1, number2, diff;
 
    printf("Enter two integers: ");
    scanf("%d %d", &number1, &number2);
 
    // calculate the diff
    diff = number1 - number2;
    printf("%d - %d = %d", number1, number2, diff);
    return 0;
}
//function added in branch1
int func_diff(int a, int b)
{
        // i am in main branch
        // i am making this changes in
        // one more change
        return a-b;
}
