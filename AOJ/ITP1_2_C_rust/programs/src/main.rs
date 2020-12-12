fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let mut vec:Vec<_> = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap()).collect();
    
    vec.sort();
    println!("{}", vec.iter().map(|n|n.to_string()).collect::<Vec<String>>().join(" "));
}
