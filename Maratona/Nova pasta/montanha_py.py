#!/usr/bin/env python2.7

N = int(raw_input())
A = [int(a) for a in raw_input().split()]

resposta = 'N'

for i in range(1,N-1):
    if ( A[i-1] > A[i] and A[i] < A[i+1] ):
        resposta = 'S'

print resposta
