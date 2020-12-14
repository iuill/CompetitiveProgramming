
// Vector, reverse版
// fn main() {
//     let mut c = String::new();
//     std::io::stdin().read_line(&mut c).ok();
//     let n = c.trim().parse::<i32>().unwrap();

//     let mut input = String::new();
//     std::io::stdin().read_line(&mut input).ok();
//     let mut vec = input.trim().split_whitespace().map(|c| c.parse::<i32>().unwrap()).collect::<Vec<i32>>();
//     vec.reverse();

//     for (&v, i) in vec.iter().zip(0..n) {
//         print!("{}{}", v, if i==n-1 {"\n"}else{" "});
//     }
// }


// fn main() {
//     let mut _c = String::new();
//     std::io::stdin().read_line(&mut _c).ok();

//     let mut input = String::new();
//     std::io::stdin().read_line(&mut input).ok();
//     let str = input.trim().split_whitespace().rev().collect::<Vec<_>>().join(" ");
//     println!("{}", str);
// }

fn main() {
    //use std::io;
    use std::io::BufRead;
    let stdin = std::io::stdin();
    let mut lines = stdin.lock().lines();

    let str = lines.nth(1).unwrap().unwrap().trim().split_whitespace().rev().collect::<Vec<_>>().join(" ");
    println!("{}", str);
}