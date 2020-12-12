// イテレータ版
// fn main() {
//     let mut input = String::new();
//     std::io::stdin().read_line(&mut input).ok();
//     let mut iter = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap());
//     let (a, b) = (iter.next().unwrap(), iter.next().unwrap());
//     println!("{} {}", a*b, a*2+b*2);
// }

// Vector版
fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let vec:Vec<_> = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap()).collect();
    let (a, b) = (vec[0], vec[1]);
    println!("{} {}", a*b, a*2+b*2);
}
