# お題１

いちごを出荷するには、品種とサイズを知る必要があります。
品種とサイズを与えて、いちごを作成し、その文字列表現を取得しましょう。
文字列表現の例: あまおう: S とちおとめ: M もういっこ: L
なお、品種は、 あまおう とちおとめ もういっこ の3種類、いちごのサイズは S M L LL の4種類です。

- [x] いちごの文字列表現が「品種: サイズ」である
  - [x] 品種が「あまおう」でサイズが「S」を指定したいちごの文字列表現は「あまおう: S」である
  - [x] 品種が「とちおとめ」でサイズが「S」を指定したいちごの文字列表現は「あまおう: S」である
  - [x] 品種が「もういっこ」でサイズが「S」を指定したいちごの文字列表現は「あまおう: S」である
- [x] サイズの種類は「S」「M」「L」「LL」が指定できる
  - [x] サイズの種類は「S」が指定できる
  - [x] サイズの種類は「M」が指定できる
  - [x] サイズの種類は「L」が指定できる
  - [x] サイズの種類は「LL」が指定できる

# お題2

いちごは重さによってサイズが決定されます。
重くなるにしたがってサイズが大きくなります。

サイズではなく、重さを直接与えて、いちごを作成できるようにしましょう。

ただし、いちごの重さは 1g以上とし 0g以下は対象としなくてよいものとします。

なお、いちごのサイズは、重さによって決まります。

重さ と サイズ の関係性は以下のとおりです。

25g以上 → LL
20g以上 → L
10g以上 → M
1g以上 → S
例えば、 重さが 8g の あまおうの場合は、 あまおう: S という文字列表現になります。


- [x] いちごに重さを直接与えてサイズの文字列表現が決まる
  - [x] 25g以上 の重さを与えると、サイズがLLである
  - [x] 20g以上~25未満 の重さを与えると、サイズがLである
  - [x] 10g以上~20未満 の重さを与えると、サイズがMである
  - [x] 1g以上~10未満 の重さを与えると、サイズがSである
  - [x] 1g未満 の重さを与えると、例外となる
 
- [ ] 品種と重さによって、いちごの文字列表現が決まる
  - [ ] 重さが 1g の あまおうの場合は、 あまおう: S という文字列表現となる
  - [ ] 重さが 10g の あまおうの場合は、 あまおう: M という文字列表現となる
  - [ ] 重さが 20g の あまおうの場合は、 あまおう: L という文字列表現となる
  - [ ] 重さが 25g の あまおうの場合は、 あまおう: LL という文字列表現となる
