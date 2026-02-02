# Архитектура проекта (упрощённая, feature-based)

Проект организован по функциональным модулям (features).  
Каждый модуль хранит в одной папке:
- страницы (XAML),
- ViewModel,
- связанную с ними логику.

Внутри модулей не используются подпапки.

## Структура папок

```
Omni/
  Platforms/
  Resources/
    Styles/

  Components/

  Pages/
    HabitsPage.xaml
    HabitEditPage.xaml
    TodosPage.xaml
    TimeTrackingPage.xaml
    MoodPage.xaml
    BodyStatsPage.xaml
    MediaListPage.xaml
    ShoppingPage.xaml

  Habits/
    HabitsViewModel.cs
    HabitEditViewModel.cs
    HabitService.cs

  Todos/
    TodosViewModel.cs
    TodoService.cs

  TimeTracking/
    TimeTrackingViewModel.cs
    TimeTrackerService.cs

  Mood/
    MoodViewModel.cs
    MoodService.cs

  BodyStats/
    BodyStatsViewModel.cs
    BodyStatsService.cs

  MediaList/
    MediaListViewModel.cs
    MediaService.cs

  Shopping/
    ShoppingViewModel.cs
    ShoppingService.cs

  App.xaml
  AppShell.xaml

```

## Назначение папок

### `Components/`
Общие переиспользуемые UI-компоненты:
- карточки,
- элементы списков,
- теги,
- рейтинги,
- модальные элементы и т.п.

Используются на разных страницах приложения.

---

### `Resources/Styles/`
Глобальные стили приложения:
- цвета,
- шрифты,
- стили контролов,
- темы (светлая/тёмная).

---

### Папки модулей (`Habits`, `Todos`, `TimeTracking` и т.д.)
Каждая папка — отдельный функциональный модуль приложения.

Внутри:
- `*Page.xaml` — UI страницы
- `*ViewModel.cs` — логика представления (состояние, команды)
- `*Service.cs` — логика работы с данными и сценариями

Пример:
- `HabitsPage.xaml` — экран привычек
- `HabitsViewModel.cs` — логика экрана
- `HabitService.cs` — операции с привычками

---

## Принципы

- UI, логика и данные группируются по функциональности, а не по типу файла
- нет вложенных подпапок внутри модулей
- каждый модуль изолирован и легко расширяется
- общие компоненты вынесены отдельно
- структура остаётся простой и читаемой при росте проекта
```