#include <stdio.h>
#include <unistd.h>

int num = 99;

int main(int argc, char** argv) {
    printf("start num is %d\n", num);
    num++;
    int rc = fork();
    if (rc > 0) {
        num += 10;
        printf("Parent's num is %d\n", num);
    } else if (rc == 0) {
        num += 30;
        printf("Child's num is %d\n", num);
    }
    num--;
    printf("end num is %d\n", num);
    return 0;
}
