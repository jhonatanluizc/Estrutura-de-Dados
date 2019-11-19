#include <stdio.h>


long long int mdc(long long int a, long long int b) {
  while (b > 0) {
    long long int r = a % b;
    a = b; b = r;
  }
  return a;
}

int main() {
  long long int n, m, x;
  scanf("%lld %lld", &n, &m);
  x = m;
  while (mdc(n, x) > 1) --x;
  printf("%lld\n", x);
  return 0;
}
