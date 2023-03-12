//тот же самый код только на котлине

import java.util.Scanner

fun main(args: Array<String>) {
    val reader = Scanner(System.`in`)
    val count: Int = reader.nextInt()
    var cur: Int = 0
    var list: IntArray = IntArray(count+1)
    while (cur != count) {
        var num: Int = reader.nextInt()
        if (num == 0) continue;
        if (num % 5 == 0) {
            list[cur] = num
        }
        cur++
    }
    val res = list.toList()
    println(res.maxOrNull() ?: 0)
}
