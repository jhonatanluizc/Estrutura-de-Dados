#include <iostream>
#include <string>
//getline(cin, S);
using namespace std;

int main()
{
    string S;

    cin >> S;
    bool q = true;
    int ini = 0, fim = S.length();

    for(int i = ini; i < fim; i++)
    {
        if(S[ini] == S[i])
        {
            string SS;

            for(int t = ini; t < i+1; t++)
            {
                SS = SS+S[i-t];
            }
            cout << SS << "\n";
            if(SS != S)
            {
                q = false;
            }
            ini = i;
        }

    }


    return 0;
}
