#include <iostream>

using namespace std;

int main()
{
    int nSala, vida = 0;
    cin >> nSala;
    int vetor[nSala];

    for(int i = 0; i < nSala; i++)
    {
        cin >> vetor[i];
    }

    for(int i = 0; i < nSala; i++)
    {
        int vidaT = 0;
        for(int j = i; j < nSala; j++)
        {
            vidaT = vetor[j] + vidaT;
            if(vidaT > vida)
            {
                vida = vidaT;
            }
        }
    }

    cout << vida << "\n";
    return 0;
}
