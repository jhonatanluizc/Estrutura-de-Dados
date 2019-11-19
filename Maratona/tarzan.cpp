#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int n, d, x0, x1, y0, y1;
    cin >> n;
    cin >> d;
    bool pode = true;

    cin >> x0;
    cin >> y0;

    for(int i = 0; i < n; i++)
    {
        cin >> x1;
        cin >> y1;
        float dist;
        dist = sqrt(pow( abs(x1-x0), 2) + pow( abs(y1-y0), 2));
        if(dist > d)
        {
            pode = false;
            break;
        }
        x0 = x1;
        y0 = y1;
    }

    if(pode)
    {
        cout << "S" << "\n";
    }
    else
    {
        cout << "N" << "\n";
    }
    return 0;
}
