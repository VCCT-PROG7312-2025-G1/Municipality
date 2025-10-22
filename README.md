# Municipality Application (PROG7312)

### Connor Gray

##### ST10263992

---

## Demo Video

Basic showcase of part 1 of application:

[Part 1 Municipality Application](https://youtu.be/7rW6xv57haM)

---

## Overview

This application is designed to help users report issues within their municipality, such as infrastructure problems or service requests. It provides a user-friendly interface for submitting, viewing, and managing reported issues.

## Features

**Main Menu:** Easy navigation to different parts of the application. Three main parts to the application: Report Issues, Local Events and Announcements, Service Request Status.

**Report Issue (Part 1):** Users can submit new issues with details and select the relevant municipality.
**Issue Management:** View and manage reported issues, displayed on the Main Menu.

**Local Events and Announcements (Part 2):** Users can review upcoming local events and announcements. They can refine what is presented using a combobox for categories, a DateTime Picker to select specific dates, and a search box. Once searched, all relevant data is presented in a visually appealing manner. Additionally, users are presented with recommended events and upcoming events.
**Events Management:** Search for events based on certain criteria, recommend events based on user searches, and show upcoming events on a calendar.

**Service Request Status (Part 3):** Users can view the status of their service requests, including the most urgent requests and an optimized route for addressing them. The user is also able to view the locations of these where these requested services are needed. These locations are clickable and will display information regarding the request.

**Colour Scheme:** Consistent and visually appealing interface, bettering user experience.

## Data Structure

**(Part 1)**
The application uses a **Linked List**, to store and manage reported issues. This allows efficient addition, removal, and traversal of issues, making it easy to keep track of all reports.

**(Part 2)**
In this part the application makes use of **LinkedLists**, **Dictionary**, **HashSet**, **SortedDictionary**, **Stack**, **Queue**. It uses these advanced data types in a number of different ways such as **categoryIndex** or **searchHistory**. These data types make it easier to do things such as searching different events for certain fields/terms.
There has also been an update on the **Main Menu**, showing the next 7 days of upcoming events.

**(Part 3)**
The application introduces the use of **AVLTree**, **MinHeap**, and **Graph** data structures to manage service requests efficiently:

- **AVLTree:** Used to store and search service requests by their unique IDs. This ensures efficient insertion, deletion, and search operations.

- **MinHeap:** Acts as a priority queue to manage active service requests based on urgency. This allows the application to retrieve the most urgent service request efficiently.

- **Graph:** Represents service request locations as vertices and connects them with weighted edges. This is used to calculate an optimized route (Minimum Spanning Tree) for addressing all service requests.

These data structures are implemented in the **Service Request Status** page to provide users with real-time updates on their requests, prioritize urgent tasks, and optimize routes for service delivery.

---

## How to Compile and Run

### Prerequisites

- .NET Framework (recommended: 4.7.2 or later)
- Visual Studio or any compatible C# IDE that can run WinForms

### Steps How to Run

1. **Open the Solution:**
   - Open `Municipality_ST10263992_PROG7312.sln` in Visual Studio.
2. **Build the Project:**
   - Click `Build > Build Solution` or press `Ctrl+Shift+B`.
3. **Run the Application:**
   - Press `F5` to run in Debug mode, or click `Start`.
   - Alternatively, run the executable from `bin/Debug/Municipality_ST10263992_PROG7312.exe`.

## How to Use

1. **Main Menu:**
   - Start the application and use the main menu to navigate.
2. **Report an Issue:**
   - Select the option to report an issue, fill in the required details, and submit.
3. **View Issues:**
   - Access the list of reported issues to view or manage them.
4. **Service Request Status:**
   - View the status of service requests, retrieve the most urgent request, and see the optimized route for addressing all requests.

---

## Acknowledgments

- **Lecturer:** Thank you to [Clivefrankland](https://github.com/Clivefrankland) for guidance and support throughout the development of this project.
- **Resources:** This project was inspired by various tutorials and documentation regarding many of the data structures and algorithms used, including [Microsoft Docs](https://learn.microsoft.com/) and [Stack Overflow](https://stackoverflow.com/) **CHANGE**.
