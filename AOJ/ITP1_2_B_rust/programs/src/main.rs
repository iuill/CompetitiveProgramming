fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let vec:Vec<_> = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap()).collect();
    let (a, b, c) = (vec[0], vec[1], vec[2]);

    if a < b && b < c {
        println!("Yes");
    }
    else {
        println!("No");
    }
}
