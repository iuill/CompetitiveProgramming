
fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let _ = input.trim().parse::<i32>().unwrap();
    
    let mut input2 = String::new();
    std::io::stdin().read_line(&mut input2).ok();
    let vec:Vec<_> = input2.trim().split_whitespace().map(|n| n.parse::<i64>().unwrap()).collect();

    let max:&i64 = vec.iter().max().unwrap();
    let min:&i64 = vec.iter().min().unwrap();
    let sum:i64 = vec.iter().sum();
    
    println!("{} {} {}", min, max, sum);
}
