fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let vec:Vec<_> = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap()).collect();
    let (a, b) = (vec[0], vec[1]);

    if a<b {
        println!("a < b");
    }
    else if a>b {
        println!("a > b");
    }
    else {
        println!("a == b");
    }
}
