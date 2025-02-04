#include <stdio.h>
#include <stdlib.h>

int* add(const int* a, const int* b) {
    if (a == NULL || b == NULL)
        return NULL;
    int *ret = malloc(sizeof(int));
    if (ret == NULL)
        return NULL;
    *ret = *a + *b;
    return ret;
}

int main(int argc, char** argv) {
    int a = 3;
    int b = 4;
    int *ret = add(&a, &b);
    if (ret == NULL)
        printf("Error\n");
    else {
        printf("3+4=%d\n", *ret);
        free(ret); // Free the allocated memory
    }
    return 0;
}

// int num = 99;


// int main(int argc, char** argv) {
//     printf("start num is %d\n", num);
//     num++;
//     int rc = fork();
//     if (rc > 0) {
//         num += 10;
//         printf("Parent's num is %d\n", num);
//     } else if (rc == 0) {
//         num += 30;
//         printf("Child's num is %d\n", num);
//     }
//     num--;
//     printf("end num is %d\n", num);
//     return 0;
// }
