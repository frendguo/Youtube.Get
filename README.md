# Youtube.Get

用于下载 Youtube 视频的 dotnet tool。

## 怎么下载？

```powershell
dotnet tool install -g vget
```

## 怎么用？

- 通过视频链接下载视频到桌面
```sh
Youtube.Get -url https://www.youtube.com/watch?v=av5YNd4X3dY
```

- 通过视频 ID 来下载
```sh
Youtube.Get -id av5YNd4X3dY
```

- 还可以通过 `-o` 来指定下载位置(无需指定视频名称，会根据视频来获取的)
```sh
Youtube.Get -url https://www.youtube.com/watch?v=av5YNd4X3dY -o D:/
```
