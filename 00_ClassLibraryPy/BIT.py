from typing import TypeVar, Generic

T = TypeVar("T", int, float)


class BIT(Generic[T]):
    """BIT - Binary Indexed Tree
        和の問い合わせをO(logN）で行うデータ構造

    Args:
        Generic (_type_): _description_
    """

    def __init__(self, n: int):
        self.n = n + 1
        self.bit = [0] * (n + 1)

    def add(self, i: int, x: T) -> None:
        idx = i

        while idx < self.n:
            self.bit[idx] += x
            idx += idx & -idx

    def sum(self, end: int, start: int = 1) -> T:
        s: T = 0

        idx = end
        while idx > 0:
            s += self.bit[idx]
            idx -= idx & -idx

        if start != 1:
            s -= self.sum(start - 1)

        return s


if __name__ == "__main__":
    a = BIT(8)
    for i, x in enumerate([1, 3, 4, 8, 6, 1, 4, 2]):
        a.add(i + 1, x)

    for i in range(1, 9):
        print(a.sum(i))

    print(a.sum(start=6, end=8))
