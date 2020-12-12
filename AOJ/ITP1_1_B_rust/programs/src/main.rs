fn main() {
    use std::io;

    let mut input = String::new();

    io::stdin().read_line(&mut input).ok();
    //let num:i32 = input.trim().parse().unwrap();
    let num = input.trim().parse::<i32>().unwrap();
    println!("{}", num*num*num);
}
