fn main() {
    let mut input = String::new();
    std::io::stdin().read_line(&mut input).ok();
    let s = input.trim().parse::<i32>().unwrap();

    let h:i32 = s / (60*60);
    let m:i32 = s / 60 % 60;
    let s:i32 = s % 60;
    println!("{}:{}:{}", h, m, s);
}
