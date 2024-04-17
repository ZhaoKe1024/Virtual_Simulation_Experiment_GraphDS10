using System.Collections;
using System.Collections.Generic;

public class ExecIns
{
    public int cdh; // cell direction: 1右 3左
    public int cmh; // cell move horizon
    public int cdv; // cell direction: 0上 2下
    public int cmv; // cell move vertical

    public int srn;
    public int scn;
    public int ern;
    public int ecn;
    public ExecIns(int a, int b, int c, int d, int e, int f, int g, int h)
    {
        this.cdh = a;
        this.cmh = b;
        this.cdv = c;
        this.cmv = d;
        this.srn = e;
        this.scn = f;
        this.ern = g;
        this.ecn = h;
    }

    public override string ToString()
    {
        string res = "d h "+cdh+" m h "+cmh+" d v "+cdv+" m v " + cmv;
        res += "开始于"+srn+"行"+scn+"列";
        return res;
    }
}
