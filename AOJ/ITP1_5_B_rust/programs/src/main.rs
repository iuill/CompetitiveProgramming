
fn main() {
    loop{
        let mut input = String::new();
        std::io::stdin().read_line(&mut input).ok();
        let vec:Vec<_> = input.trim().split_whitespace().map(|n| n.parse::<i32>().unwrap()).collect();
        let (h, w) = (vec[0], vec[1]);

        if h==0 && w==0
        { return; }

        for i in 0..h {
            for j in 0..w {
                let c = if i == 0 || i == h - 1 || j == 0 || j == w - 1 {
                    "#"
                } else {
                    "."
                };
                print!("{}", c);
            }
            println!();
        }
        println!();
    }
}
